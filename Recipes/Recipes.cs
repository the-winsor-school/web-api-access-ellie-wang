using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net.Http;

namespace InternetData.Properties
{
    public class Recipes
    {
        public static RecipeInfo getRecipeInfo(string meal)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(
                HttpMethod.Get,
                string.Format("https://www.themealdb.com/api/json/v1/1/search.php?s={0}", meal));

            HttpResponseMessage response = client.SendAsync(request).Result;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RecipesList));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            return ((RecipesList)serializer.ReadObject(response.Content.ReadAsStreamAsync().Result)).meals[0];
        }

        [DataContract] //structure that lets us use the JSON serializer
        public class RecipesList //declaring the class
        {
            [DataMember] //a decoration: DataMember is everything that comes from the API
            public List<RecipeInfo> meals;
        }

        [DataContract]
        public class RecipeInfo //declaring a class of all the attributes of a recipe; all string names are what they're called on the website
        {
            [DataMember]
            public string idMeal; //meal ID: a number that identifies it within the website's database

            [DataMember]
            public string strMeal; //name of the meal

            [DataMember]
            public string strDrinkAlternate; //suggested drink

            [DataMember]
            public string strCategory;

            [DataMember]
            public string strArea;

            [DataMember]
            public string strInstructions;

            [DataMember]
            public string strMealThumb;

            [DataMember]
            public string strTags;

            [DataMember]
            public string strYoutube;

            [DataMember]
            public string strIngredient1;

            [DataMember]
            public string strIngredient2;

            [DataMember]
            public string strIngredient3;

            [DataMember]
            public string strIngredient4;

            [DataMember]
            public string strIngredient5;

            [DataMember]
            public string strIngredient6;

            [DataMember]
            public string strIngredient7;

            [DataMember]
            public string strIngredient8;

            [DataMember]
            public string strIngredient9;

            [DataMember]
            public string strIngredient10;

            [DataMember]
            public string strIngredient11;

            [DataMember]
            public string strIngredient12;

            [DataMember]
            public string strIngredient13;

            [DataMember]
            public string strIngredient14;

            [DataMember]
            public string strIngredient15;

            [DataMember]
            public string strIngredient16;

            [DataMember]
            public string strIngredient17;

            [DataMember]
            public string strIngredient18;

            [DataMember]
            public string strIngredient19;

            [DataMember]
            public string strIngredient20;

            [DataMember]
            public string strMeasure1;

            [DataMember]
            public string strMeasure2;

            [DataMember]
            public string strMeasure3;

            [DataMember]
            public string strMeasure4;

            [DataMember]
            public string strMeasure5;

            [DataMember]
            public string strMeasure6;

            [DataMember]
            public string strMeasure7;

            [DataMember]
            public string strMeasure8;

            [DataMember]
            public string strMeasure9;

            [DataMember]
            public string strMeasure10;

            [DataMember]
            public string strMeasure11;

            [DataMember]
            public string strMeasure12;

            [DataMember]
            public string strMeasure13;

            [DataMember]
            public string strMeasure14;

            [DataMember]
            public string strMeasure15;

            [DataMember]
            public string strMeasure16;

            [DataMember]
            public string strMeasure17;

            [DataMember]
            public string strMeasure18;

            [DataMember]
            public string strMeasure19;

            [DataMember]
            public string strMeasure20;

            [DataMember]
            public string strSource;

            [DataMember]
            public string dateModified;
        }
    }
}
