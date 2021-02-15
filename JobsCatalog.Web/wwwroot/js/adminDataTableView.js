$(document).ready(function () {
    $("#adminDataTableView").DataTable({
        //Disable sorting on edit and view button
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort']
        }],
    
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": "/Admin/Job/GetJobs",
            "type": "POST",
            "datatype": "json"
        },
        
        "columns": [
            { "data": "id", "name": "Id", "autoWidth": true },
            { "data": "title", "name": "Title", "autoWidth": true },
            { "data": "opening", "name": "Opening", "autoWidth": true },
           
            { "data": "postedOn", "name": "PostedOn", "autoWidth": true ,
               "render": function (data) {
                var date = new Date(data);
                var month = date.getMonth() + 1;
                return (month.length > 1 ? month : "0" + month) + "/" + date.getDate() + "/" + date.getFullYear() + "&nbsp;&nbsp;" +(date.getHours() < 10 ? ("0"+date.getHours()) : date.getHours())+ ":"+(date.getMinutes() < 10 ? ("0"+date.getMinutes()) : date.getMinutes()) ;
            }},
        
            {
                'render': function (date) {
                     
                     return "<a id='editBtn2' style='cursor:pointer'); ><i class='fas fa-briefcase'></i></a>";
                }
            },

           
        ]
    });
    //GET Id JOBID is in 0 Index
    // $("#jobDataTable").on('click', '#editBtn', function(e){
    //     e.preventDefault();
    //     var ID = $(this).closest('tr').find('td').eq(0).text();
    //     window.location = "EditJob/"+ID+"";
    // });
    
   
});  
