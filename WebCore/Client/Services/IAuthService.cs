﻿using InventoryManagement.Shared.Models;

namespace InventoryManagement.WebCore.Client.Services;

public interface IAuthService
{
    Task Login(LoginRequest loginRegisterRequest);
    Task Register(RegisterRequest userRegisterAccount);
    Task ChangePassword(ChangePasswordRequest changePasswordRequest);
    Task ChangePasswordAdmin(ChangePasswordRequest changePasswordRequest);
    Task Logout();
    Task<CurrentUser> CurrentUserInfo();

}
