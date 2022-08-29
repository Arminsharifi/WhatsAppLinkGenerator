import type Data from "../dto/Data";

async function sendData(data: Data): Promise<string | null> {
    const url: string = 'http://localhost:5000/api/v1.0/LinkGenerator';
    const response: Response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json;charset=utf-8",
            accept: "*/*",
        },
        body: JSON.stringify(data),
        credentials: 'include',
        redirect: 'follow'
    });
    let result: string = "";
    if (response.ok) {
        let resjson: string = await response.json();
        result = resjson;
    } else {
        let errortext = await response.text();
        console.log(errortext);
        throw new Error(response.statusText + ": " + errortext);
     }
    return result;
}


export {sendData};