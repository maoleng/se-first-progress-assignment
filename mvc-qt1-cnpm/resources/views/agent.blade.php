@extends('admin-theme.master')

@section('title')
    Manage Agent
@endsection

@section('content')
    <div class="row" id="basic-table">
        <div class="col-12">
            <div class="card">
                <div class="row d-flex justify-content-between align-items-center m-1">
                    <div class="col-lg-6 d-flex align-items-start">
                        <div class="dt-action-buttons text-xl-end text-lg-start text-lg-end text-start ">
                            <div class="dt-buttons">
                                <div class="btn-group">
                                    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
                                        Add Agent
                                    </button>
                                    <div class="dropdown-menu">
                                        <form action="{{ route('agent.store') }}" method="post" class="px-2 py-2 width-350">
                                            @csrf
                                            <div class="mb-1">
                                                <label class="form-label" for="exampleDropdownFormEmail1">Name</label>
                                                <input name="AgentName" type="text" class="form-control" id="exampleDropdownFormEmail1" placeholder="Name" />
                                            </div>
                                            <div class="mb-1">
                                                <label class="form-label" for="exampleDropdownFormEmail1">Address</label>
                                                <input name="Address" type="text" class="form-control" id="exampleDropdownFormEmail1" placeholder="Address" />
                                            </div>
                                            <div class="mb-0">
                                                <button type="submit" class="btn btn-primary">Add</button>
                                            </div>
                                        </form>
                                        <div class="dropdown-divider"></div>
                                    </div>
                                </div>
                                <div class="btn-group dropup">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="table-responsive">
                    <table class="table">
                        <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Address</th>
                        </tr>
                        </thead>
                        <tbody>
                        @foreach ($agents as $agent)
                            <tr>
                                <td>{{ $agent->AgentID }}</td>
                                <td>{{ $agent->AgentName }}</td>
                                <td>{{ $agent->Address }}</td>
                            </tr>
                        @endforeach
                        </tbody>
                    </table>
                </div>
                <div class="m-3">{{ $agents->withQueryString()->links('vendor.pagination') }}</div>
            </div>
        </div>
    </div>
@endsection

@section('vendor_style')
    <link rel="stylesheet" type="text/css" href="{{ asset('app-assets/vendors/css/pickers/flatpickr/flatpickr.min.css') }}">

    <link rel="stylesheet" type="text/css" href="{{ asset('app-assets/vendors/css/animate/animate.min.css') }}">
    <link rel="stylesheet" type="text/css" href="{{ asset('app-assets/vendors/css/extensions/sweetalert2.min.css') }}">
@endsection

@section('page_style')
    <link rel="stylesheet" type="text/css" href="{{ asset('app-assets/css/plugins/forms/pickers/form-flat-pickr.css') }}">

    <link rel="stylesheet" type="text/css" href="{{ asset('app-assets/css/plugins/extensions/ext-component-sweet-alerts.css') }}">
@endsection

@section('page_vendor_script')
    <script src="{{ asset('app-assets/vendors/js/pickers/flatpickr/flatpickr.min.js') }}"></script>

    <script src="{{ asset('app-assets/vendors/js/extensions/sweetalert2.all.min.js') }}"></script>
    <script src="{{ asset('app-assets/vendors/js/extensions/polyfill.min.js') }}"></script>
@endsection

@section('page_script')
    <script src="{{ asset('app-assets/js/scripts/forms/pickers/form-pickers.js') }}"></script>
    <script src="{{ asset('app-assets/js/scripts/components/components-dropdowns.js') }}"></script>
    <script src="{{ asset('assets/js/handle_search.js') }}"></script>

    <script>
        {!! successAlert() !!}
            {!! errorAlert() !!}
            const btn_lock = $('.btn-lock')
        btn_lock.on('click', function () {
            const form_id = $(this).parent().attr('id')
            Swal.fire({
                title: 'Are you sure?',
                text: $(this).data('message'),
                icon: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Yes!',
                customClass: {
                    confirmButton: 'btn btn-primary',
                    cancelButton: 'btn btn-outline-danger ms-1'
                },
                buttonsStyling: false
            }).then(function (result) {
                if (result.value) {
                    $(`#${form_id}`).submit()
                }
            });
        });
    </script>
@endsection
