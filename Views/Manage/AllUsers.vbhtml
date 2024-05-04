@ModelType IEnumerable(Of ApplicationUser)

@Code
    ViewData("Title") = "Collaborators"
End Code

<h2>Collaborators</h2>


<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserName)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.UserName)
            </td>
        </tr>
    Next

</table>
