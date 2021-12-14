using AnimeApi;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AnimeDotNet.Tests
{
	public class AnimeTests
	{
		private readonly IAnime _anime;

		public AnimeTests()
		{
			_anime = new AnimeRepository();
		}

		[Theory]
		[InlineData("Demon Slayer")]
		public async Task GetAnime_InvalidName_ShouldThrowJsonException(string name)
		{

			// Then
			await Assert.ThrowsAsync<JsonException>(() => _anime.GetAnime(name));

		}

		[Theory]
		[InlineData("Naruto")]
		[InlineData("Fate stay night")]
		[InlineData("When they cry")]
		public async Task GetAnime_CorrectName_ShouldReturnNoThrowException(string name)
		{
			// When
			GetAnime returnedGetAnime = await _anime.GetAnime(name);

			// Then
			Assert.NotNull(returnedGetAnime);
		}

		[Fact]
		public async Task GetAnime_NarutoName_ShouldParseNaruto()
		{
			// When
			AnimeApi.GetAnime result = await _anime.GetAnime("Naruto");
			IList<Datum> animes = result.data;
			// Then
			Assert.Equal("Naruto", animes.First().attributes.titles.en);
		}

		[Fact]
		public async Task GetAnime_HigurashiName_ShouldParseWhenTheyCry()
		{
			// When
			AnimeApi.GetAnime result = await _anime.GetAnime("When they cry");
			IList<Datum> animes = result.data;
			// Then
			Assert.Equal("When They Cry: Kai", animes.First().attributes.titles.en);
		}


		[Fact]
		public async Task GetTrendingAnimeShouldParseNotNull()
		{
			// When
			AnimeApi.TrendingAnime result = await _anime.GetTrending();
			IList<Datum> animes = result.data;
			// Then
			Assert.NotNull(animes);
			Assert.Equal(10, animes.Count);
		}


		[Fact]
		public async Task GetTrendingAnimeShouldRateHigh()
		{
			// When
			AnimeApi.TrendingAnime result = await _anime.GetTrending();
			IList<Datum> animes = result.data;
			// Then
			Assert.NotNull(animes);
			Assert.Equal(10, animes.Count);

			Assert.True(float.Parse(animes.First().attributes.averageRating) > 80, "Expected averageRating to be greater than 80.");
		}


		[Theory]
		[InlineData("Seibā")]
		[InlineData("Ní maith liom an bháisteach")]
		public async Task GetAnime_InvalidName_ShouldThrowLanguageException(string name)
		{

			// Then
			await Assert.ThrowsAsync<AnimeApi.CustomException<AnimeApi.InvalidLangauge>>(() => _anime.GetAnime(name));
		}


		[Theory]
		[InlineData("")]
		[InlineData(null)]
		public async Task GetAnime_InvalidName_ShouldThrowNoNameException(string name)
		{
			// Then
			await Assert.ThrowsAsync<AnimeApi.CustomException<AnimeApi.NoName>>(() => _anime.GetAnime(name));


		}
	}
}