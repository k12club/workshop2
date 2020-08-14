var test = [
        {
                name: "เขตตรวจราชการที่ 1"
        },
        {
                name: "เขตตรวจราชการที่ 1"
        }
]

const regex = /(ตรวจราชการ)/g;

var tesr =  test.map(result=>{
        return result.name.match(regex);
})
console.log(tesr);
// // const found = paragraph.match(regex);

// var tesst2 = "afskfsd33j"
// var test2 = tesst2.match(/a(.*)j/);
// alert (test2);