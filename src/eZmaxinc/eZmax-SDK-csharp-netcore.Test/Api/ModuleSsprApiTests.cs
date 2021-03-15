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
    ///  Class for testing ModuleSsprApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModuleSsprApiTests : IDisposable
    {
        private ModuleSsprApi instance;

        public ModuleSsprApiTests()
        {
            instance = new ModuleSsprApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModuleSsprApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModuleSsprApi
            //Assert.IsType<ModuleSsprApi>(instance);
        }

        /// <summary>
        /// Test SsprResetPasswordRequestV1
        /// </summary>
        [Fact]
        public void SsprResetPasswordRequestV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprResetPasswordRequestV1Request ssprResetPasswordRequestV1Request = null;
            //instance.SsprResetPasswordRequestV1(ssprResetPasswordRequestV1Request);
        }

        /// <summary>
        /// Test SsprResetPasswordV1
        /// </summary>
        [Fact]
        public void SsprResetPasswordV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprResetPasswordV1Request ssprResetPasswordV1Request = null;
            //instance.SsprResetPasswordV1(ssprResetPasswordV1Request);
        }

        /// <summary>
        /// Test SsprSendUsernamesV1
        /// </summary>
        [Fact]
        public void SsprSendUsernamesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprSendUsernamesV1Request ssprSendUsernamesV1Request = null;
            //instance.SsprSendUsernamesV1(ssprSendUsernamesV1Request);
        }

        /// <summary>
        /// Test SsprUnlockAccountRequestV1
        /// </summary>
        [Fact]
        public void SsprUnlockAccountRequestV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprUnlockAccountRequestV1Request ssprUnlockAccountRequestV1Request = null;
            //instance.SsprUnlockAccountRequestV1(ssprUnlockAccountRequestV1Request);
        }

        /// <summary>
        /// Test SsprUnlockAccountV1
        /// </summary>
        [Fact]
        public void SsprUnlockAccountV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprUnlockAccountV1Request ssprUnlockAccountV1Request = null;
            //instance.SsprUnlockAccountV1(ssprUnlockAccountV1Request);
        }

        /// <summary>
        /// Test SsprValidateTokenV1
        /// </summary>
        [Fact]
        public void SsprValidateTokenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsprValidateTokenV1Request ssprValidateTokenV1Request = null;
            //instance.SsprValidateTokenV1(ssprValidateTokenV1Request);
        }
    }
}
