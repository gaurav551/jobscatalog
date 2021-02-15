$(document).ready(function () {
    $("#jobDataTable").DataTable({
        //Disable sorting on edit and view button
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort']
        }],
    
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": "/Employer/GetJobs",
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
                "render": function (data,row) 
                {
                     return "<a id='editBtn' class='btn btn-success btn-xs'); ><i class='ti-pencil'></i></a>";


               }
            },
            {
                'render': function (date) {
                     
                     return "<a id='editBtn2' class='btn btn-primary btn-xs'); ><i class='ti-eye'></i></a>";
                }
            },

           
        ]
    });
    //GET Id JOBID is in 0 Index
    $("#jobDataTable").on('click', '#editBtn', function(e){
        e.preventDefault();
        var ID = $(this).closest('tr').find('td').eq(0).text();
        window.location = "EditJob/"+ID+"";
    });
    
   
});  
