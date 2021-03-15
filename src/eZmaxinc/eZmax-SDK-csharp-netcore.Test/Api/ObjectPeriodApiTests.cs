/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    ///  Class for testing ObjectPeriodApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectPeriodApiTests : IDisposable
    {
        private ObjectPeriodApi instance;

        public ObjectPeriodApiTests()
        {
            instance = new ObjectPeriodApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectPeriodApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectPeriodApi
            //Assert.IsType<ObjectPeriodApi>(instance);
        }

        /// <summary>
        /// Test PeriodGetAutocompleteV1
        /// </summary>
        [Fact]
        public void PeriodGetAutocompleteV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sSelector = null;
            //string sQuery = null;
            //var response = instance.PeriodGetAutocompleteV1(sSelector, sQuery);
            //Assert.IsType<CommonGetAutocompleteV1Response>(response);
        }
    }
}
