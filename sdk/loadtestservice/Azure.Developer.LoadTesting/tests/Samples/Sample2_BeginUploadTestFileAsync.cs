﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Developer.LoadTesting.Tests.Samples
{
    public partial class LoadTestingSamples: SamplesBase<LoadTestingClientTestEnvironment>
    {
        [Test]
        [AsyncOnly]
        public async Task BeginUploadTestFileAsync()
        {
#if SNIPPET
            // The data-plane endpoint is obtained from Control Plane APIs with "https://"
            // To obtain endpoint please follow: https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/loadtestservice/Azure.Developer.LoadTesting#data-plane-endpoint
            Uri endpointUrl = new Uri("https://" + <your resource URI obtained from steps above>);
            TokenCredential credential = new DefaultAzureCredential();
#else
            string endpoint = TestEnvironment.Endpoint;
            Uri endpointUrl = new Uri("https://" + endpoint);
            TokenCredential credential = TestEnvironment.Credential;
#endif

            // creating LoadTesting Administration Client
            LoadTestAdministrationClient loadTestAdministrationClient = new LoadTestAdministrationClient(endpointUrl, credential);

            #region Snippet:Azure_Developer_LoadTesting_BeginUploadTestFileAsync

            string testId = "my-loadtest";

            try
            {
                // poller object
                FileUploadOperation operation = await loadTestAdministrationClient.UploadTestFileAsync(WaitUntil.Started, testId, "sample.jmx", RequestContent.Create(
                        Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sample.jmx")
                    ));

                // get the intial reponse for uploading file
                Response initialResponse = operation.GetRawResponse();
                Console.WriteLine(initialResponse);

                // run lro to check the validation of file uploaded
                await operation.WaitForCompletionAsync();

                // printing final response
                Response validatedFileResponse = operation.GetRawResponse();
                Console.WriteLine(validatedFileResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
