
export default class Vehicule {

    constructor(id, startDate = new Date()) {
        this._id = id;
        this._startDate = startDate;
        this._endDate = '';
    }

    get id() { return this._id }
    get startDate() { return this._startDate }
    get endDate() { return this._endDate }

    changeEndDate(date) {
        this._endDate = date;
        // console.log("date" + date);
        // console.log("endDate" +this._endDate);
    }

}

