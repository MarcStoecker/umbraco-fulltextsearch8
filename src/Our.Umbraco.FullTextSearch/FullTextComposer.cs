﻿using Our.Umbraco.FullTextSearch.Interfaces;
using Our.Umbraco.FullTextSearch.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Our.Umbraco.FullTextSearch
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class FullTextComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<FullTextSearchConfig>(Lifetime.Singleton);
            composition.Register<ISearchService, SearchService>(Lifetime.Request);
            composition.Register<IHtmlService, HtmlService>(Lifetime.Singleton);
            composition.Register<ICacheService, CacheService>(Lifetime.Singleton);
        }
    }
}
