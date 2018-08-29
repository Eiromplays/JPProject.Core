﻿using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;

namespace Equinox.UI.SSO.Util
{
    public class ClientResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                // some standard scopes from the OIDC spec
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),

                // custom identity resource with some consolidated claims
                new IdentityResource("picture", new[] { JwtClaimTypes.Picture }),

                // add additional identity resource
                new IdentityResource("roles", "Roles", new[] { "role" })
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                // simple version with ctor
                new ApiResource("api1", "Some API 1")
                                {
                    // this is needed for introspection when using reference tokens
                    ApiSecrets = { new Secret("secret".Sha256()) }
                                },
                new ApiResource("UserManagementApi", "User Management API"), 
                // expanded version if more control is needed
                //new ApiResource
                //                {
                //                    Name = "UserManagementApi",
                //                    DisplayName = "User Management API",
                //                    Description = "API with default and protected actions to register and manager User",
                //                    ApiSecrets = { new Secret("Q&tGrEQMypEk.XxPU:%bWDZMdpZeJiyMwpLv4F7d**w9x:7KuJ#fy,E8KPHpKz++".Sha256()) },

                //                    UserClaims =
                //                    {
                //                        JwtClaimTypes.Profile,
                //                        JwtClaimTypes.Name,
                //                        JwtClaimTypes.Email,
                //                        JwtClaimTypes.Picture
                //                    },

                //                    Scopes =
                //                    {
                //                        new Scope()
                //                        {
                //                            Name = "UserManagementApi.owner-content",
                //                            DisplayName = "Full access",
                //                            Description = "Full access to User Management",
                //                            Required = true
                //                        }

                //                    }
                //                }
                        };
        }
    }
}