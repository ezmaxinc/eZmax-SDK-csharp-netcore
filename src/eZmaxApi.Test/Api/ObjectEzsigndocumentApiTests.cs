/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.44
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
    ///  Class for testing ObjectEzsigndocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsigndocumentApiTests : IDisposable
    {
        private ObjectEzsigndocumentApi instance;

        public ObjectEzsigndocumentApiTests()
        {
            instance = new ObjectEzsigndocumentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsigndocumentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsigndocumentApi
            //Assert.IsType<ObjectEzsigndocumentApi>(instance);
        }

        /// <summary>
        /// Test EzsigndocumentApplyEzsigntemplateV1
        /// </summary>
        [Fact]
        public void EzsigndocumentApplyEzsigntemplateV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //EzsigndocumentApplyEzsigntemplateV1Request ezsigndocumentApplyEzsigntemplateV1Request = null;
            //var response = instance.EzsigndocumentApplyEzsigntemplateV1(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV1Request);
            //Assert.IsType<EzsigndocumentApplyEzsigntemplateV1Response>(response);
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
            //Assert.IsType<EzsigndocumentCreateObjectV1Response>(response);
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
            //Assert.IsType<EzsigndocumentDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsigndocumentGetChildrenV1
        /// </summary>
        [Fact]
        public void EzsigndocumentGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //instance.EzsigndocumentGetChildrenV1(pkiEzsigndocumentID);
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
            //Assert.IsType<EzsigndocumentGetDownloadUrlV1Response>(response);
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
            //Assert.IsType<EzsigndocumentGetObjectV1Response>(response);
        }
    }
}
