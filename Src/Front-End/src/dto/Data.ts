export default class Data {
    public phoneNumber : string;
    public text : string;

    constructor(strjson: string) {
        Object.assign(this, strjson);
    }
}
