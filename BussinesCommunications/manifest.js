'use strict';
window.addEventListener("DOMContentLoaded",  () => {
    AddRowTable();
});

function AddRowTable() {
    const addBtn = document.querySelector('.add-row');
    var blockNumber = 2;
    addBtn.onclick = () => {
        // Создаем блок и добавляем номер
        const MainDiv = document.getElementById("MainTD");
        const createRow = document.createElement('div');
        createRow.className = 'row';
        createRow.id= 'R'+blockNumber;
        const createBlock1 = document.createElement('div');
        createBlock1.className = 'Cell1';
        const input1 = document.createElement('input');
        input1.type = 'text';
        input1.id = 'InpCell1_'+blockNumber;
        const createBlock2 = document.createElement('div');
        createBlock2.className = 'Cell2';
        const input2 = document.createElement('input');
        input2.type = 'text';
        input2.id = 'InpCell2_'+blockNumber;
        /*input2.addEventListener('keydown', function() {
            if(input2!="" && input3!="")
            {
                createBlock4.innerHTML = Number(input2.value)+Number(input3.value);
            }
           })*/
        const createBlock3 = document.createElement('div');
        createBlock3.className = 'Cell3';
        const input3 = document.createElement('input');
        input3.type = 'text';
        input3.id = 'InpCell3_'+blockNumber;
        const createBlock4 = document.createElement('div');
        createBlock4.className = 'Cell4';
        const input4 = document.createElement('input');
        input4.type = 'text';
        input4.id = 'InpCell4_'+blockNumber;
        createBlock1.appendChild(input1);
        createRow.appendChild(createBlock1);
        createBlock2.appendChild(input2);
        createRow.appendChild(createBlock2);
        createBlock3.appendChild(input3);
        createRow.appendChild(createBlock3);
        createBlock4.appendChild(input4);
        createRow.appendChild(createBlock4);
        blockNumber++;
        addBtn.insertAdjacentElement('beforebegin', createRow);
        MainDiv.appendChild(createRow);
        const createBR = document.createElement('br');
        addBtn.insertAdjacentElement('beforebegin', createBR);
        MainDiv.appendChild(createBR);
    }
    const Itogo = document.querySelector('.Itogo');
    Itogo.onclick = () => {
        let Result = 0;
        for( var i=2;i<blockNumber;i++)
            {
                Result = Result + Number(document.getElementById('InpCell4_'+i).value);
            }
        document.getElementById("Result").innerHTML = Result;
    }
}