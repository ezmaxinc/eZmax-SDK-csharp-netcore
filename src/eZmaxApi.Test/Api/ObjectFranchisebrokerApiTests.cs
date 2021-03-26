/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.39
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

using eZmaxApi.Client;
using eZmaxApi.Api;
// uncomment below to import models
//using eZmaxApi.Model;

namespace eZmaxApi.Test.Api
{
    /// <summary>
    ///  Class for testing ObjectFranchisebrokerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectFranchisebrokerApiTests : IDisposable
    {
        private ObjectFranchisebrokerApi instance;

        public ObjectFranchisebrokerApiTests()
        {
            instance = new ObjectFranchisebrokerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectFranchisebrokerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectFranchisebrokerApi
            //Assert.IsType<ObjectFranchisebrokerApi>(instance);
        }

        /// <summary>
        /// Test FranchisebrokerGetAutocompleteV1
        /// </summary>
        [Fact]
        public void FranchisebrokerGetAutocompleteV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sSelector = null;
            //string sQuery = null;
            //var response = instance.FranchisebrokerGetAutocompleteV1(sSelector, sQuery);
            //Assert.IsType<CommonGetAutocompleteV1Response>(response);
        }
    }
}
