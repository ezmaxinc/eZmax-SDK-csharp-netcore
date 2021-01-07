/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.24
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
    ///  Class for testing ObjectEzsignsignatureApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignsignatureApiTests : IDisposable
    {
        private ObjectEzsignsignatureApi instance;

        public ObjectEzsignsignatureApiTests()
        {
            instance = new ObjectEzsignsignatureApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsignsignatureApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsignsignatureApi
            //Assert.IsType<ObjectEzsignsignatureApi>(instance);
        }

        /// <summary>
        /// Test EzsignsignatureCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsignsignatureCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsignsignatureCreateObjectV1Request> ezsignsignatureCreateObjectV1Request = null;
            //var response = instance.EzsignsignatureCreateObjectV1(ezsignsignatureCreateObjectV1Request);
            //Assert.IsType<EzsignsignatureCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignsignatureDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsignsignatureDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignsignatureID = null;
            //var response = instance.EzsignsignatureDeleteObjectV1(pkiEzsignsignatureID);
            //Assert.IsType<EzsignsignatureDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignsignatureEditObjectV1
        /// </summary>
        [Fact]
        public void EzsignsignatureEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignsignatureID = null;
            //EzsignsignatureEditObjectV1Request ezsignsignatureEditObjectV1Request = null;
            //var response = instance.EzsignsignatureEditObjectV1(pkiEzsignsignatureID, ezsignsignatureEditObjectV1Request);
            //Assert.IsType<EzsignsignatureEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignsignatureGetObjectGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsignsignatureGetObjectGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignsignatureID = null;
            //instance.EzsignsignatureGetObjectGetChildrenV1(pkiEzsignsignatureID);
        }

        /// <summary>
        /// Test EzsignsignatureGetObjectV1
        /// </summary>
        [Fact]
        public void EzsignsignatureGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignsignatureID = null;
            //var response = instance.EzsignsignatureGetObjectV1(pkiEzsignsignatureID);
            //Assert.IsType<EzsignsignatureGetObjectV1Response>(response);
        }
    }
}
