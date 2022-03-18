import {StatusCodes} from "http-status-codes";
import { NextFunction, Request, Response, Router } from "express";

const usersRoute =Router();
usersRoute.get('/users', (req:Request, res:Response, next:NextFunction) => {
    const users = [{userName:'João Paulo'}];
    res.status(StatusCodes.OK).send({users});
});

usersRoute.get('/users/:uuid', (req:Request<{ uuid: string}>, res:Response, next:NextFunction) =>{
    const uuid =req.params.uuid;
    res.status(StatusCodes.OK).send({uuid}); 
});

usersRoute.post('./users', (req:Request<{ uuid: string}>, res:Response, next:NextFunction) =>{
    const newUser = req.body;
    res.status(StatusCodes.CREATED).send(newUser);
});

usersRoute.put('/users/:uuid', (req:Request<{ uuid: string}>, res:Response, next:NextFunction) =>{
    const uuid = req.params.uuid;
    const modifiedUser = req.body;

    modifiedUser.uuid = uuid;

    res.status(StatusCodes.OK).send(modifiedUser);
});

usersRoute.delete('./users/:uuid', (req:Request<{ uuid: string}>, res:Response, next:NextFunction) =>{
    res.status(StatusCodes.OK);
});

export default usersRoute;