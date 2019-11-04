﻿using System.ComponentModel.DataAnnotations;

namespace JPProject.Sso.Application.ViewModels.UserViewModels
{
    public class RemoveUserRoleViewModel
    {
        public RemoveUserRoleViewModel(string username, string role)
        {
            Username = username;
            Role = role;
        }

        [Required]
        public string Role { get; set; }
        [Required]
        public string Username { get; set; }

    }
}