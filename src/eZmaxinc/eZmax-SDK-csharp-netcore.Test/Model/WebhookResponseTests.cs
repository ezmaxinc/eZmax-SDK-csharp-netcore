/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.21
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
    ///  Class for testing WebhookResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WebhookResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WebhookResponse
        //private WebhookResponse instance;

        public WebhookResponseTests()
        {
            // TODO uncomment below to create an instance of WebhookResponse
            //instance = new WebhookResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookResponse
        /// </summary>
        [Fact]
        public void WebhookResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" WebhookResponse
            //Assert.IsType<WebhookResponse>(instance);
        }


        /// <summary>
        /// Test the property 'pkiWebhookID'
        /// </summary>
        [Fact]
        public void pkiWebhookIDTest()
        {
            // TODO unit test for the property 'pkiWebhookID'
        }
        /// <summary>
        /// Test the property 'eWebhookModule'
        /// </summary>
        [Fact]
        public void eWebhookModuleTest()
        {
            // TODO unit test for the property 'eWebhookModule'
        }
        /// <summary>
        /// Test the property 'eWebhookEzsignevent'
        /// </summary>
        [Fact]
        public void eWebhookEzsigneventTest()
        {
            // TODO unit test for the property 'eWebhookEzsignevent'
        }
        /// <summary>
        /// Test the property 'pksCustomerCode'
        /// </summary>
        [Fact]
        public void pksCustomerCodeTest()
        {
            // TODO unit test for the property 'pksCustomerCode'
        }
        /// <summary>
        /// Test the property 'sWebhookUrl'
        /// </summary>
        [Fact]
        public void sWebhookUrlTest()
        {
            // TODO unit test for the property 'sWebhookUrl'
        }
        /// <summary>
        /// Test the property 'sWebhookEmailfailed'
        /// </summary>
        [Fact]
        public void sWebhookEmailfailedTest()
        {
            // TODO unit test for the property 'sWebhookEmailfailed'
        }

    }

}
