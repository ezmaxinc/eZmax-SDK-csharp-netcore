/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.28
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Test.Model
{
    /// <summary>
    ///  Class for testing EzsignsignerRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EzsignsignerRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EzsignsignerRequest
        //private EzsignsignerRequest instance;

        public EzsignsignerRequestTests()
        {
            // TODO uncomment below to create an instance of EzsignsignerRequest
            //instance = new EzsignsignerRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EzsignsignerRequest
        /// </summary>
        [Fact]
        public void EzsignsignerRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" EzsignsignerRequest
            //Assert.IsType<EzsignsignerRequest>(instance);
        }


        /// <summary>
        /// Test the property 'fkiTaxassignmentID'
        /// </summary>
        [Fact]
        public void fkiTaxassignmentIDTest()
        {
            // TODO unit test for the property 'fkiTaxassignmentID'
        }
        /// <summary>
        /// Test the property 'fkiSecretquestionID'
        /// </summary>
        [Fact]
        public void fkiSecretquestionIDTest()
        {
            // TODO unit test for the property 'fkiSecretquestionID'
        }
        /// <summary>
        /// Test the property 'eEzsignsignerLogintype'
        /// </summary>
        [Fact]
        public void eEzsignsignerLogintypeTest()
        {
            // TODO unit test for the property 'eEzsignsignerLogintype'
        }
        /// <summary>
        /// Test the property 'sEzsignsignerSecretanswer'
        /// </summary>
        [Fact]
        public void sEzsignsignerSecretanswerTest()
        {
            // TODO unit test for the property 'sEzsignsignerSecretanswer'
        }

    }

}
