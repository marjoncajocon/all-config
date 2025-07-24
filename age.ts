function GetAge(cur_date: Date, from_date: Date): string {
  
  // cur_date can be using, new Date()

  const date_info:{n: number, d: string, v: number}[] = [
    { n: 31536000000, d: 'Y', v: 0 },
    { n: 2592000000,  d: 'M', v: 0 },
    { n: 604800000,   d: 'W', v: 0 },
    { n: 86400000,    d: 'D', v: 0 },
    { n: 3600000,     d: 'h', v: 0 },
    { n: 60000,       d: 'm', v: 0 },
    { n: 1000,        d: 's', v: 0 }
  ];

 
  let time = cur_date.getTime() - from_date.getTime();

  const top_date : {n: number, d: string, v:number}[] = [];
  let flag = false;

  for (const d of date_info) {
    
    const v = Math.floor(time / d.n);

    const mod = time % d.n;

    time = mod;
    d.v = v;

    
    if (v > 0) flag = true;

    if (flag) {
        top_date.push(d);
    }

  }


  const ret : {n: number, d: string, v: number}[] = [];

  flag = false;
  
  // trim end
  for (let i = top_date.length - 1; i >= 0; i--) {
    let item = top_date[i];
    if (item.v > 0) flag = true;
    if (flag) {
        ret.push(item);
    }
  }

  const rev = ret.reverse();


  const resp: string[] = [];

  for (const item of rev) {
    resp.push(`${item.v}${item.d}`);
  }


  return resp.join(" ");
} 

/*
1        * 1000 = 1           - 1 sec
60       * 1000 = 60000       - 1 minute
60000    * 60   = 3600000     - 1 hour
3600000  * 24   = 86400000    - 1 day
86400000 * 7    = 604800000   - 1 week
86400000 * 30   = 2592000000  - 1 month
86400000 * 365  = 31536000000 - 1 year

*/

export {GetAge};
