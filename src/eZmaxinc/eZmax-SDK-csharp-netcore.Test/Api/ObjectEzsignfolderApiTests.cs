/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.27
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
    ///  Class for testing ObjectEzsignfolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignfolderApiTests : IDisposable
    {
        private ObjectEzsignfolderApi instance;

        public ObjectEzsignfolderApiTests()
        {
            instance = new ObjectEzsignfolderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsignfolderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsignfolderApi
            //Assert.IsType<ObjectEzsignfolderApi>(instance);
        }

        /// <summary>
        /// Test EzsignfolderCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsignfolderCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsignfolderCreateObjectV1Request> ezsignfolderCreateObjectV1Request = null;
            //var response = instance.EzsignfolderCreateObjectV1(ezsignfolderCreateObjectV1Request);
            //Assert.IsType<EzsignfolderCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfolderDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsignfolderDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //var response = instance.EzsignfolderDeleteObjectV1(pkiEzsignfolderID);
            //Assert.IsType<EzsignfolderDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfolderEditObjectV1
        /// </summary>
        [Fact]
        public void EzsignfolderEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //EzsignfolderEditObjectV1Request ezsignfolderEditObjectV1Request = null;
            //var response = instance.EzsignfolderEditObjectV1(pkiEzsignfolderID, ezsignfolderEditObjectV1Request);
            //Assert.IsType<EzsignfolderEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfolderGetObjectGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsignfolderGetObjectGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //instance.EzsignfolderGetObjectGetChildrenV1(pkiEzsignfolderID);
        }

        /// <summary>
        /// Test EzsignfolderGetObjectV1
        /// </summary>
        [Fact]
        public void EzsignfolderGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //var response = instance.EzsignfolderGetObjectV1(pkiEzsignfolderID);
            //Assert.IsType<EzsignfolderGetObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfolderSendV1
        /// </summary>
        [Fact]
        public void EzsignfolderSendV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //EzsignfolderSendV1Request ezsignfolderSendV1Request = null;
            //var response = instance.EzsignfolderSendV1(pkiEzsignfolderID, ezsignfolderSendV1Request);
            //Assert.IsType<EzsignfolderSendV1Response>(response);
        }
    }
}
