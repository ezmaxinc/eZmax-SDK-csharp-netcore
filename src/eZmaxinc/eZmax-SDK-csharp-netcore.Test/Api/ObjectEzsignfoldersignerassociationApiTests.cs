/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.37
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
        /// Test EzsignfoldersignerassociationGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsignfoldersignerassociationGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //instance.EzsignfoldersignerassociationGetChildrenV1(pkiEzsignfoldersignerassociationID);
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
