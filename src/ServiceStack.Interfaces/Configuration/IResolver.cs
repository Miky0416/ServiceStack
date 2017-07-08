﻿using System;

namespace ServiceStack.Configuration
{
    public interface IResolver
    {
        /// <summary>
        /// Resolve a dependency from the AppHost's IOC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T TryResolve<T>();
    }

    public interface IHasResolver
    {
        IResolver Resolver { get; }
    }

    public interface IContainer
    {
        Func<object> CreateFactory(Type type);

        void AddSingleton(Type type, Func<object> factory);
        
        void AddTransient(Type type, Func<object> factory);

        object Resolve(Type type);
    }
}