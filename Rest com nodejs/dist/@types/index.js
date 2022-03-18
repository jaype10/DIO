"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var express_1 = __importDefault(require("express"));
var users_route_1 = __importDefault(require("../routes/users.route"));
var app = (0, express_1.default)();
app.use(users_route_1.default);
app.get('/status', function (req, res, next) {
    res.status(200).send({ foo: 'Sucesso !' });
});
app.listen(3000, function () {
    console.log('Aplicação executando na porta 3000!');
});
