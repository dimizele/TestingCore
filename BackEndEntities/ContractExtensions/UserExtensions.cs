using BackEndEntities.Contracts;
using RestSharp;
using SupportClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndEntities.ContractExtensions
{
    public static class UserExtensions
    {
        public static RestRequest CreatePostUserRequest(this User user)
        {
            return new RestRequest()
                .WithResource(user.UserEndPoint)
                .WithMethod(Method.POST)
                .WithRequestFormat(DataFormat.Json)
                .WithJsonBody(user.Serialize());
        }
    }
}
