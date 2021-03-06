﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using AdvancedREI.Net.Http.Compression;
using Newtonsoft.Json;
using System.Data;

namespace PhoneApp1
{
    /// <summary>
    /// Static class for fetching match data.
    /// </summary>
    public static class MatchDataFetcher
    {
        /// <summary>
        /// Read zipped html page and return its content as string.
        /// </summary>
        /// <param name="pageAdress">The address of the zipped page.</param>
        /// <returns>Content of the page as a string.</returns>
        public static async Task<string> readCompressedHtmlPageAsync(string pageAdress)
        {
            CompressedHttpClientHandler handler = new CompressedHttpClientHandler();
            HttpClient client = new HttpClient(handler);

            HttpResponseMessage response = await client.GetAsync(pageAdress);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            
            return content;
        }


    }
}
