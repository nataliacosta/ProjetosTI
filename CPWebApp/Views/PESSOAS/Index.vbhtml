@ModelType IEnumerable(Of CPWebApp.CPWebApp.PESSOAS)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.nome)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PESSOAS2.nome)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.PESSOAS2.nome)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
