﻿using Geair.DTOLayer.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Geair.WebUI.ViewComponents._BlogComponents;

public class _BlogListComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogListComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var res = new System.Net.Http.HttpResponseMessage();
        if (id > 0)
        {
            // id > 0 ise, kategoriId'ye göre getirir. Değilse tümünü getirir.
            res = await client.GetAsync("https://localhost:7151/api/Blogs/GetBlogByCategoryIdListHome?id=" + id);
        } else
        {
            res = await client.GetAsync("https://localhost:7151/api/Blogs");
        }
        var readData = await res.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultBlogDto>>(readData);
        return View(values);
    }
}
