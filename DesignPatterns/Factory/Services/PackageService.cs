﻿using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Services
{
    public class PackageService
    {
        private IPackageFactory packageFactory;

        public PackageService(IPackageFactory factory)
        {
            packageFactory = factory;
        }

        public void RunFactoryMethod()
        {
            IPackage package = GetPackage();
            package.Deliver();
        }

        public IPackage GetPackage()
        {
            return packageFactory.CreatePackage();
        }
    }
}
