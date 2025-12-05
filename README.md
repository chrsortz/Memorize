✅ Create.cshtml
<pre> '''text @model NewProject.Models.Employee
<h2>Create Employee</h2>

<form method="post">
    <label>First Name</label>
    <input class="form-control" asp-for="FirstName" />

    <label>Last Name</label>
    <input class="form-control" asp-for="LastName" />

    <label>Age</label>
    <input class="form-control" asp-for="Age" />

    <label>Email</label>
    <input class="form-control" asp-for="Email" />

    <button class="btn btn-success" type="submit">Save</button>
</form>
</pre>

✅ Delete.cshtml
<pre> '''text @model NewProject.Models.Employee
<h2>Delete Employee</h2>

<p>Are you sure you want to delete <strong>@Model.FirstName @Model.LastName</strong>?</p>

<form method="post">
    <button class="btn btn-danger">Delete</button>
    <a href="/Employee">Cancel</a>
</form>
</pre>

✅ Details.cshtml
<pre> '''text @model NewProject.Models.Employee
<h2>Employee Details</h2>

<p><strong>Name:</strong> @Model.FirstName @Model.LastName</p>
<p><strong>Age:</strong> @Model.Age</p>
<p><strong>Email:</strong> @Model.Email</p>

<a href="/Employee">Back</a>
</pre>

✅ Edit.cshtml
<pre> '''text @model NewProject.Models.Employee
<h2>Edit Employee</h2>

<form method="post">
    <input type="hidden" asp-for="Id" />

    <label>First Name</label>
    <input class="form-control" asp-for="FirstName" />

    <label>Last Name</label>
    <input class="form-control" asp-for="LastName" />

    <label>Age</label>
    <input class="form-control" asp-for="Age" />

    <label>Email</label>
    <input class="form-control" asp-for="Email" />

    <button class="btn btn-primary">Update</button>
</form>
</pre>

✅ Index.cshtml
<pre> '''text @model IEnumerable<NewProject.Models.Employee>

<h2>Employees</h2>
<a class="btn btn-primary" href="/Employee/Create">Create New</a>

<table class="table">
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Age</th>
            <th>Email</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>@item.FirstName</td>
                <td>@item.LastName</td>
                <td>@item.Age</td>
                <td>@item.Email</td>
                <td>
                    <a href="/Employee/Edit/@item.Id">Edit</a> |
                    <a href="/Employee/Details/@item.Id">Details</a> |
                    <a href="/Employee/Delete/@item.Id">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>
</pre>
