$('#table-contatos').DataTable({
    "ordering": true,
    "paging": true,
    "searching": true,
    "oLanguage": {
        "sEmptyTable": "Nenhum registro encontrado na tabela",
        "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
        "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
        "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
        "sInfoPostFix": "",
        "sInfoThousands": ".",
        "sLengthMenu": "Mostrar _MENU_ registros por pagina",
        "sLoadingRecords": "Carregando...",
        "sProcessing": "Processando...",
        "sZeroRecords": "Nenhum registro encontrado",
        "sSearch": "Pesquisar",
        "oPaginate": {
            "sNext": "Proximo",
            "sPrevious": "Anterior",
            "sFirst": "Primeiro",
            "sLast": "Ultimo"
        },
        "oAria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma descendente"
        }
    }
});

$("#cep").on("blur", function () {

    let cep = this.value;

    if (!cep) {
        return;
    }

    $.ajax({
        type: 'GET',
        url: `https://viacep.com.br/ws/${cep}/json/`,
        success: function (result) {
            $('#Logradouro').prop("value", result.logradouro);
            $('#Complemento').prop("value", result.complemento);
            $('#Bairro').prop("value", result.bairro);
            $('#Municipio').prop("value", result.localidade);
            $('#UnidadeFederativa').prop("value", result.uf);
        }
    });
    
});

$("#CpfCnpj").on("blur", function () {
    let cnpj = this.value;
    let tipoPessoa = $("#Tipo").val();
    
    if (cnpj.length != 14 || tipoPessoa != 'PJ') {
        return;
    }
    
    $.ajax({
        type: 'GET',
        url: `/Contato/ObterInformacoesCNPJ/${cnpj}`,
        success: function (result) {
            result = JSON.parse(result);
            $('#Nome').prop("value", result.nome);
            $('#NomeAbreviado').prop("value", result.fantasia);
            console.log(result);
        }
    });

});

$('.close-alert').click(function() {
    $('.alert').hide('hide');
});