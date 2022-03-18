"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var http_status_codes_1 = require("http-status-codes");
var express_1 = require("express");
var usersRoute = (0, express_1.Router)();
usersRoute.get('/users', function (req, res, next) {
    var users = [{ userName: 'João Paulo' }];
    res.status(http_status_codes_1.StatusCodes.OK).send({ users: users });
});
usersRoute.get('/users/:uuid', function (req, res, next) {
    var uuid = req.params.uuid;
    res.status(http_status_codes_1.StatusCodes.OK).send({ uuid: uuid });
});
exports.default = usersRoute;
