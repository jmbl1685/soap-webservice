var app = angular.module("myApp", [])

app.controller("myController", function ($scope, people) {


    people.GetPeople().then(function (res) {
        console.log(res.data)
    });

})

app.service('people', function ($http) {

    this.AddPeople = function (body) {
        return $http({
            method: 'POST',
            data: body,
            url: '/WebSite.WebApi/api/people',
            headers: { 'Content-Type': 'application/json' }
        }).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }

    this.GetPeople = function () {
        return $http({
            method: 'GET',
            url: '/WebSite.WebApi/api/people',
            headers: { 'Content-Type': 'application/json' }
        }).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }

    this.UpdatePeople = function (id, body) {
        return $http({
            method: 'GET',
            url: '/WebSite.WebApi/api/people/' + id,
            data: body,
            headers: { 'Content-Type': 'application/json' }
        }).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }

    this.removePeople = function (id) {
        return $http({
            method: 'GET',
            url: '/WebSite.WebApi/api/people/' + id,
            headers: { 'Content-Type': 'application/json' }
        }).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }

})