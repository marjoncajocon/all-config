
//sample tsx for network search react-select

import AsyncSelect from "react-select/async";

<AsyncSelect name="code" cacheOptions loadOptions={async(inputValue: string): Promise<UacsEntity[]> => {
    try {
        const res = await fetch_json('/api/general/search_g_uacs', {search: inputValue}) as {
            "key": string,
            "value": string
        }[];

        const newData: UacsEntity[] = [];

        for (const item of res) {
            newData.push({
                value: item.key,
                label: item.value    
            });
        }

        return newData;
    } catch (error) {
        console.error("Fetch error:", error);
        return []; 
    }
}} defaultOptions onChange={(v) => {
    console.log(v);
}} />
