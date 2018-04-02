// ***********************************************************************
// Assembly         : Helper
// Author           : yubaolee
// Created          : 12-16-2016
//
// Last Modified By : yubaolee
// Last Modified On : 12-21-2016
// 使用微软默认带超时的Cache
// File: CacheContext.cs
// ***********************************************************************

using Microsoft.Extensions.Caching.Memory;
using System;
using System.Web;

namespace Infrastructure.Cache
{
    public class CacheContext : ICacheContext
    {
        private readonly IMemoryCache _memoryCache;

        public CacheContext(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public override T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key);
        }

        public override bool Set<T>(string key, T t, DateTime expire)
        {
            var obj = Get<T>(key);
            if (obj != null)
            {
                Remove(key);
            }
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(expire.Second));
            _memoryCache.Set<T>(key, t, cacheEntryOptions);
            return true;
        }

        public override bool Remove(string key)
        {
            _memoryCache.Remove(key);
            return true;
        }
    }
}
