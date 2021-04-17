//import { Modal } from "bootstrap";

$("#ActersId").change(function () {

    var optionSelected = $("option:selected", this)
    var selectedName = optionSelected.text()
    $("#ActersName").val(selectedName)

});

$("#CategoryId").change(function () {

    var optionSelected = $("option:selected", this)
    var selectedName = optionSelected.text()
    $("#CategoryName").val(selectedName)

});

$("#GenreId").change(function () {

    var optionSelected = $("option:selected", this)
    var selectedName = optionSelected.text()
    $("#GenreName").val(selectedName)

});

$("#ProducerId").change(function () {

    var optionSelected = $("option:selected", this)
    var selectedName = optionSelected.text()
    $("#ProducerName").val(selectedName)

});

$("#ProductionId").change(function () {

    var optionSelected = $("option:selected", this)
    var selectedName = optionSelected.text()
    $("#ProductionName").val(selectedName)

});

//$("#addNewAuthor").click(function () {

//    console.log("modal button author add new author");
//    $.ajax({
//        type: "POST",
//        url: "",
//        data: { someParameter: "some value" },
//        contentType: "aplication/json; charset=UTF-8",
//        dataType: "json",
//        succes: function (msg) {
//            //Replae the div's with the page method's return.
//            $("#Result").text(msg.d);
//        }
//    });

//});

$("#addNewProducerBtn").click(function () {
    var data = {
        Name: $("#ProducerNameDTO").val(),
        Country: $("#ProducerCountryDTO").val(),
        BirthDate: $("#ProducerBirthDateDTO").val(),
        YearsActive: $("#ProducerYearsActiveDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Producer/CreateProducerAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data !== '') {
                $("#ProducerModal").modal("toggle");
                setTimeout(() => {
                    alert("ERROR: Producer is not added")
                }, 500);
            }
            else {
                $("#ProducerId").append("<option value=" + data.data.id + ">" + data.name + "</option>");
                $("#ProducerId").val(data.data.id);
                $("#ProducerModal").modal('toggle');
            }
        },
        error: function () {
            alert("ERROR: Producer has not added!!!")
        }
    });

});

$("#addNewActorBtn").click(function () {

    var data = {
        Name: $("#ActorNameDTO").val(),
        Country: $("#ActorCountryDTO").val(),
        BirthDate: $("#ActorBirthDateDTO").val(),
        YearsActive: $("#ActorYearsActiveDTO").val(),
        Awards: $("#ActorAwardsDTO").val(),
        Gender: $("#ActorGenderDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Actor/CreateActorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data !== '') {
                $("#ActorModal").modal("toggle");
                setTimeout(() => {
                    alert("ERROR: Actor is not added");
                },500);
            }
            else {
                $("#ActersId").append("<option value=" + data.data.id + ">" + data.name + "</option>");
                $("#ActersId").val(data.data.id);
                $("#ActorModal").modal("toggle");
            }
        },
        error: function () {
            alert("ERROR: Actor has not added!!!")
        }
    });

});

$("#addNewProductionBtn").click(function () {
    var data = {
        Name: $("#ProductionNameDTO").val(),
        Country: $("#ProductionCountryDTO").val(),
        Year: $("#ProductionYearDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Production/CreateProductionAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data !== '') {
                $("#ProductionModal").modal("toggle");
                setTimeout(() => {
                    alert("ERROR: Production is not added");
                }, 500);
            }
            else {
                $("#ProductionId").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#ProductionId").val(data.data.id);
                $("#ProductionModal").modal("toggle");
            }
        },
        error: function () {
            alert("ERROR: Production has not added!!!");
        }
    });
});

$("#addNewCategoryBtn").click(function () {
    var data = {
        Name: $("#CategoryNameDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Category/CreateCategoryAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data !== '') {
                $("#CategoryModal").modal('toggle');
                setTimeout(() => {
                    alert("ERROR: Category is not added")
                }, 500);
            }
            else {
                $("#CategoryId").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#CategoryId").val(data.data.id);
                $("#CategoryModal").modal('toggle');
            }
        },
        error: function () {
            alert("ERROR: Category has not added!!!");
        }
    });
});

$("#addNewGenreBtn").click(function () {
    var data = {
        Name: $("#GenreNameDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Genre/CreateGenreAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data !== '') {
                $("#GenreModal").modal('toggle');
                setTimeout(() => {
                    alert("ERROR: Genre is not added");
                }, 500);
            }
            else {
                $("#GenreId").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#GenreId").val(data.data.id);
                $("#GenreModal").modal("toggle");
            }
        },
        error: function () {
            alert("ERROR: Genre has not added!!!");
        }
    });
});

// Redirect From Movie Index To Producer Details
function RedirectToProducerDetails(id) {
    $.ajax({
        type: 'GET', 
        success: function () {
            console.log(id);
            window.location.href = "/Producer/Details/" + id;
        },
        error: function () {
            alert("ERROR: producer was not founded!!!");
        }
    });
};

// Redirect From Movie Index To Actor Details
function RedirectToActorDetails(id) {
    $.ajax({
        type: 'GET',
        success: function () {
            console.log(id);
            window.location.href = "/Actor/Details/" + id;
        },
        error: function() {
            alert("ERROR: Actor was not founded!!!")
        }
    });
};


 //***** Upload Photo *****

$("#uploadPhoto").click(function () {
    var data = new FormData();
    var files = $("#photoUpload").get(0).files;

    if (files.length > 0) {
        data.append("UploadedImage", files[0]);
        console.log(data);
    }

    $.ajax({
        type: "POST",
        url: "/Movie/UploadPhoto",
        data: data,
        contentType: false,
        processData: false,
        success: function (data) {
            console.log(data.dbPath);
            $("#URL").val(data.dbPath);
        },
        error: function () {
            alert("Error Uploading Photo!");
        }
    });

});