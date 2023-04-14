<?php

namespace App\Http\Controllers;

use App\Models\Agent;
use Illuminate\Http\Request;

class AgentController extends Controller
{

    public function index()
    {
        $agents = Agent::query()->orderByDesc('AgentID')->paginate(10);

        return view('agent', [
            'agents' => $agents,
        ]);
    }

    public function store(Request $request)
    {
        $data = $request->except('_token');
        Agent::query()->create([
            'AgentName' => $data['AgentName'],
            'Address' => $data['Address'],
        ]);

        return redirect()->back();
    }
}
