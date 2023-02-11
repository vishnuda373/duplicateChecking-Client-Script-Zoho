
var mobile = ZDK.Page.getField("Mobile").getValue();
var msg = '';
if (mobile != null) {
    var resp_search_mobile = ZDK.Apps.CRM.Leads.searchByPhone(mobile);
    if (resp_search_mobile.length > 0) {
        msg = "Duplicate lead exists with same mobile";
    }
}
if(msg) {
    log(msg);
    ZDK.Client.showAlert(msg);
}               