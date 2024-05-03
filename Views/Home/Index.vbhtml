@Code
    ViewData("Title") = "Cadastro de Apoio a uma Causa"
End Code
<div class="jumbotron">
    <h1>Sign Up and Support a Cause!</h1>
    <p class="lead">Join us to make a difference. Each sign-up is a step towards a better world.</p>
</div>

<div class="row">
    <div class="col-md-6">
        <div class="card">
            <div class="card-body">
                <h2 class="card-title">Join Us</h2>
                <p class="card-text">Click the button below to sign up and be part of this cause.</p>
                <p><a class="btn btn-primary" href="@Url.Action("Register", "Account")">Sign Up &raquo;</a></p>
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="card">
            <div class="card-body">
                <h2 class="card-title">See Who's Already Supporting</h2>
                <p class="card-text">See all the users who are already registered and supporting this cause.</p>
                <p><a class="btn btn-secondary" href="@Url.Action("AllUsers", "Manage")">View Users &raquo;</a></p>
            </div>
        </div>
    </div>
</div>
