<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ListBoxDemo.Models.ViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Index</title>    
</head>
<body>
    <h2>Christmas gift list</h2>
    
    <p>Select up to 3 gifts from the list below up to a total value of 400</p>
    
    <%using(Html.BeginForm()){ %>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Available</th><th>&nbsp;</th><th>Requested</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td valign="top">
                            <%=Html.ListBoxFor(model => model.AvailableSelected, new SelectList(Model.AvailableProducts, "Id", "Name", Model.AvailableSelected), new { size = "6" })%>
                        </td>
                        <td valign="top">
                            <input type="submit" name="add" id="add" value=">>" /><br />
                            <input type="submit" name="remove" id="remove" value="<<" />
                        </td>
                        <td valign="top">
                            <%=Html.ListBoxFor(model => model.RequestedSelected, new MultiSelectList(Model.RequestedProducts, "Id", "Name", Model.RequestedSelected))%>
                        </td>
                    </tr>
                </tbody>
            </table>
            <br />
            <%=Html.HiddenFor(model=>model.SavedRequested) %>                    
            
            <fieldset>
                <legend>Your wish list</legend>
                <table>
                    <thead>
                        <tr>
                            <th>Product</th>
                            <th>Description</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                            <td><span id="total" style="font-weight:bold;"><%=Model.RequestedTotal.ToString("G") %></span></td>
                        </tr>
                    </tfoot> 
                    <tbody id="tableBody">
                    <%foreach(var product in Model.RequestedProducts) { %>
                        <tr>
                            <td><%=product.Name %></td>
                            <td><%=product.Description %></td>
                            <td><%=product.Price.ToString("G") %></td>
                        </tr>
                    <%} %>
                    </tbody>                         
                </table>
            </fieldset>
            <input type="submit" name="send" id="send" value="Send to Santa!" />
            <%=Html.ValidationSummary() %>
        </div>
    <%} %>
</body>
</html>
