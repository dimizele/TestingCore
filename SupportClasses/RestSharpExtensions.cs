using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace SupportClasses
{
    public static class RestSharpExtensions
    {
        public static RestRequest WithResource(this RestRequest restRequest, string endPoint)
        {
            restRequest.Resource = endPoint;

            return restRequest;
        }

        public static RestRequest WithMethod(this RestRequest restRequest, Method method)
        {
            restRequest.Method = method;

            return restRequest;
        }

        public static RestRequest WithRequestFormat(this RestRequest restRequest, DataFormat dataFormat)
        {
            restRequest.RequestFormat = dataFormat;

            return restRequest;
        }

        public static RestRequest WithJsonBody(this RestRequest restRequest, string json)
        {
            restRequest.AddJsonBody(json);

            return restRequest;
        }
    }
}
