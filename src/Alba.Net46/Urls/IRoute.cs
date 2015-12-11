﻿using Alba.Routing;

namespace Alba.Urls
{
    public interface IRoute
    {
        Route Route { get; }

        string HttpMethod { get; }

        void Register(IUrlGraph graph);

        bool HasParameters { get; }
    }
}