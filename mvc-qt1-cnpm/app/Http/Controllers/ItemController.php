<?php

namespace App\Http\Controllers;

use App\Models\Item;
use Illuminate\Http\Request;

class ItemController extends Controller
{

    public function index()
    {
        $items = Item::query()->orderByDesc('ItemID')->paginate(10);

        return view('item', [
            'items' => $items,
        ]);
    }

    public function store(Request $request)
    {
        $data = $request->except('_token');
        Item::query()->create([
            'ItemName' => $data['ItemName'],
            'Size' => $data['Size'],
            'Price' => (float) $data['Price'],
        ]);

        return redirect()->back();
    }
}
