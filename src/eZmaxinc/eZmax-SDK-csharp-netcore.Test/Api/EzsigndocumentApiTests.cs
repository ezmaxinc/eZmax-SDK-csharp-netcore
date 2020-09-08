/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.13
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
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Test
{
    /// <summary>
    ///  Class for testing EzsigndocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EzsigndocumentApiTests : IDisposable
    {
        private EzsigndocumentApi instance;

        public EzsigndocumentApiTests()
        {
            instance = new EzsigndocumentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EzsigndocumentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EzsigndocumentApi
            //Assert.IsType(typeof(EzsigndocumentApi), instance, "instance is a EzsigndocumentApi");
        }

        
        /// <summary>
        /// Test EzsigndocumentCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsigndocumentCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsigndocumentCreateObjectV1Request> ezsigndocumentCreateObjectV1Request = null;
            //var response = instance.EzsigndocumentCreateObjectV1(ezsigndocumentCreateObjectV1Request);
            //Assert.IsType<EzsigndocumentCreateObjectV1Response> (response, "response is EzsigndocumentCreateObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsigndocumentDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //var response = instance.EzsigndocumentDeleteObjectV1(pkiEzsigndocumentID);
            //Assert.IsType<EzsigndocumentDeleteObjectV1Response> (response, "response is EzsigndocumentDeleteObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentEditObjectV1
        /// </summary>
        [Fact]
        public void EzsigndocumentEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //EzsigndocumentEditObjectV1Request ezsigndocumentEditObjectV1Request = null;
            //var response = instance.EzsigndocumentEditObjectV1(pkiEzsigndocumentID, ezsigndocumentEditObjectV1Request);
            //Assert.IsType<EzsigndocumentEditObjectV1Response> (response, "response is EzsigndocumentEditObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentGetDownloadUrlV1
        /// </summary>
        [Fact]
        public void EzsigndocumentGetDownloadUrlV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //string eDocumentType = null;
            //var response = instance.EzsigndocumentGetDownloadUrlV1(pkiEzsigndocumentID, eDocumentType);
            //Assert.IsType<EzsigndocumentGetDownloadUrlV1Response> (response, "response is EzsigndocumentGetDownloadUrlV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentGetObjectGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsigndocumentGetObjectGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //instance.EzsigndocumentGetObjectGetChildrenV1(pkiEzsigndocumentID);
            
        }
        
        /// <summary>
        /// Test EzsigndocumentGetObjectV1
        /// </summary>
        [Fact]
        public void EzsigndocumentGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //var response = instance.EzsigndocumentGetObjectV1(pkiEzsigndocumentID);
            //Assert.IsType<EzsigndocumentGetObjectV1Response> (response, "response is EzsigndocumentGetObjectV1Response");
        }
        
    }

}
