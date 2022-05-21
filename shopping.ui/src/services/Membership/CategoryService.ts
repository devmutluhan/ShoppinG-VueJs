import { Category } from "@/models/entities/Category";
import { HttpClient } from "../HttpClient";
import { BaseService,ServiceBase } from "../BaseService";

export class CategoryService extends BaseService<Category> {
    constructor(){
        super("category");
    }
    
}