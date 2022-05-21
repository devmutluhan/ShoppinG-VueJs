import { ApiResult } from "../models/ApiResult";
import { AxiosResponse } from "axios";
import { HttpClient } from "./HttpClient";

export class ServiceBase {
    baseUrl = "/api/v1/membership/";
    public client: HttpClient;
    constructor(baseUrl = "") {
        this.baseUrl += baseUrl;
        this.client = new HttpClient();
    }

}
export class BaseService<TEntity>   {
    baseUrl = "/api/v1/membership/";
    public client: HttpClient;
    constructor(baseUrl = "") {
        this.baseUrl += baseUrl;
        this.client = new HttpClient();
    }
    GetAll(Limit = 50, Page = 1, Search = ""):
        Promise<AxiosResponse<ApiResult<TEntity[]>>> {
        return this.client.Get<ApiResult<TEntity[]>>(this.baseUrl + "/All?Limit=" + Limit + "&Page=" + Page + "&Search=" + Search);
    }
    GetById(id: number): Promise<AxiosResponse<ApiResult<TEntity>>> {
        return this.client.Get<ApiResult<TEntity>>(this.baseUrl + '/' + id);
    }
    Add(item: TEntity): Promise<AxiosResponse<ApiResult<TEntity>>> {
        return this.client.Post<ApiResult<TEntity>>(this.baseUrl, item);
    }
    Delete(id: number): Promise<AxiosResponse<ApiResult<TEntity>>> {
        return this.client.Delete<ApiResult<TEntity>>(this.baseUrl + '/' + id, id);
    }
    Update(item: TEntity): Promise<AxiosResponse<ApiResult<TEntity>>> {
        return this.client.Put<ApiResult<TEntity>>(this.baseUrl, item);
    }
}