/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
    ///  Class for testing ObjectEzsignfoldersignerassociationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignfoldersignerassociationApiTests : IDisposable
    {
        private ObjectEzsignfoldersignerassociationApi instance;

        public ObjectEzsignfoldersignerassociationApiTests()
        {
            instance = new ObjectEzsignfoldersignerassociationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsignfoldersignerassociationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsignfoldersignerassociationApi
            //Assert.IsType<ObjectEzsignfoldersignerassociationApi>(instance);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsignfoldersignerassociationCreateObjectV1Request> ezsignfoldersignerassociationCreateObjectV1Request = null;
            //var response = instance.EzsignfoldersignerassociationCreateObjectV1(ezsignfoldersignerassociationCreateObjectV1Request);
            //Assert.IsType<EzsignfoldersignerassociationCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationDeleteObjectV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsType<EzsignfoldersignerassociationDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationEditObjectV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //EzsignfoldersignerassociationEditObjectV1Request ezsignfoldersignerassociationEditObjectV1Request = null;
            //var response = instance.EzsignfoldersignerassociationEditObjectV1(pkiEzsignfoldersignerassociationID, ezsignfoldersignerassociationEditObjectV1Request);
            //Assert.IsType<EzsignfoldersignerassociationEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationGetInPersonLoginUrlV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationGetInPersonLoginUrlV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationGetInPersonLoginUrlV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsType<EzsignfoldersignerassociationGetInPersonLoginUrlV1Response>(response);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationGetObjectGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationGetObjectGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //instance.EzsignfoldersignerassociationGetObjectGetChildrenV1(pkiEzsignfoldersignerassociationID);
        }

        /// <summary>
        /// Test EzsignfoldersignerassociationGetObjectV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationGetObjectV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsType<EzsignfoldersignerassociationGetObjectV1Response>(response);
        }
    }
}
