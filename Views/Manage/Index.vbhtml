@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
End Code

<div class="container">
    <h2>@ViewBag.Title.</h2>

    <p class="text-success">@ViewBag.StatusMessage</p>
    <div>
        <h4>Change your account settings</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>Password:</dt>
            <dd>
                [
                @If Model.HasPassword Then
                    @<text><a href="@Url.Action("ChangePassword", "Manage")">Change your password</a></text>
                Else
                    @<text><a href="@Url.Action("SetPassword", "Manage")">Create</a></text>
                End If
                ]
            </dd>
        </dl>
    </div>
</div>
