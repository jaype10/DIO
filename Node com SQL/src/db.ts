import { Pool } from "pg";

const connectionString ='';//coloque sua URL entre as ''

const db = new Pool({connectionString});

export default db;