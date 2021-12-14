using System;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization;

namespace AnimeApi {


	public class CustomException<T> : Exception where T : Exception
	{
		public CustomException() { }
		public CustomException(string message) : base(message) { }
		public CustomException(string message, Exception innerException) : base(message, innerException) { }
		public CustomException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}


	public class InvalidLangauge : Exception { }
	public class NoName : Exception { }

	public interface IAnime
	{

		Task<GetAnime> GetAnime(string name);
		Task<TrendingAnime> GetTrending();


	}


	public class AnimeRepository : IAnime { 

		private readonly HttpClient _httpClient;
		private JsonSerializerOptions options;

		public AnimeRepository()
		{
			_httpClient = new HttpClient
			{
				BaseAddress = new Uri("https://kitsu.io/api/")
			};

		}

	private async Task<T> ExecuteGetRequest<T>(string[] args) where T : class
		{
			T returnedObject = null;
			var requestUrl = string.Join("/", args);
			try
			{
				using HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
				if (response.IsSuccessStatusCode)
				{
					string json = await response.Content.ReadAsStringAsync();
					// this doesn't want to work for some reason
					options = new JsonSerializerOptions {
						IgnoreNullValues = true
					};


					returnedObject = JsonSerializer.Deserialize<T>(json, options);
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
			return returnedObject;
		}


		public async Task<GetAnime> GetAnime(string name)

		{   if (String.IsNullOrEmpty(name))
            {
				throw new CustomException<NoName>("This method requires an anime name.");
			}
			Regex rx = new Regex("/[一-龠]+|[ぁ-ゔ]+|[ァ-ヴー]+|[a-zA-Z0-9 ]+|[ａ-ｚＡ-Ｚ０-９]+|[々〆〤]+/u?", RegexOptions.Compiled | RegexOptions.IgnoreCase);


			foreach (char c in name)
			{
				if (!rx.IsMatch(c.ToString()))
				{

					throw new CustomException<InvalidLangauge>("Only English (alpha no special) and Japanese characters are allowed.");
				}
			}


			string[] endpointParts = new string[] {"edge", "", "anime?filter[text]=" + System.Net.WebUtility.HtmlEncode(name)};
			return await ExecuteGetRequest<GetAnime>(endpointParts);
		}



		public async Task<TrendingAnime> GetTrending()
		{
			string[] endpointParts = new string[] { "edge", "trending", "anime"};
			return await ExecuteGetRequest<TrendingAnime>(endpointParts);
		}
	}

 
}
