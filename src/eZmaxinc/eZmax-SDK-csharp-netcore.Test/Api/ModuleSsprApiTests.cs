/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.31
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
// uncomment below to import models
//using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Test.Api
{
    /// <summary>
    ///  Class for testing ModuleSsprApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModuleSsprApiTests : IDisposable
    {
        private ModuleSsprApi instance;

        public ModuleSsprApiTests()
        {
            instance = new ModuleSsprApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModuleSsprApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModuleSsprApi
            //Assert.IsType<ModuleSsprApi>(instance);
        }

        /// <summary>
        /// Test SsprRemindUsernamesV1
        /// </summary>
        [Fact]
        public void SsprRemindUsernamesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.SsprRemindUsernamesV1();
        }
    }
}
