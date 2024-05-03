Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class update
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropTable("dbo.ExternalLoginConfirmationViewModels")
            DropTable("dbo.ExternalLoginListViewModels")
            DropTable("dbo.ForgotPasswordViewModels")
            DropTable("dbo.ForgotViewModels")
            DropTable("dbo.LoginViewModels")
            DropTable("dbo.RegisterViewModels")
            DropTable("dbo.ResetPasswordViewModels")
            DropTable("dbo.SendCodeViewModels")
            DropTable("dbo.VerifyCodeViewModels")
        End Sub
        
        Public Overrides Sub Down()
            CreateTable(
                "dbo.VerifyCodeViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Provider = c.String(nullable := False),
                        .Code = c.String(nullable := False),
                        .ReturnUrl = c.String(),
                        .RememberBrowser = c.Boolean(nullable := False),
                        .RememberMe = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.SendCodeViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .SelectedProvider = c.String(),
                        .ReturnUrl = c.String(),
                        .RememberMe = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ResetPasswordViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False),
                        .Password = c.String(nullable := False, maxLength := 100),
                        .ConfirmPassword = c.String(),
                        .Code = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.RegisterViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False),
                        .Password = c.String(nullable := False, maxLength := 100),
                        .ConfirmPassword = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.LoginViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False),
                        .Password = c.String(nullable := False),
                        .RememberMe = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ForgotViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ForgotPasswordViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ExternalLoginListViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .ReturnUrl = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ExternalLoginConfirmationViewModels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Email = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
    End Class
End Namespace
