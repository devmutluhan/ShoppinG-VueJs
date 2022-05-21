import { API_BASE } from '@/config/settings';
import axios from "axios";

const axiosConf = axios.create({ baseURL: API_BASE });




export default axiosConf;