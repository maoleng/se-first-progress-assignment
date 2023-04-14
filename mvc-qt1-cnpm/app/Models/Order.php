<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Order extends Model
{
    use HasFactory;
    protected $table = 'order';
    protected $primaryKey = 'OrderID';
    public $timestamps = false;

    protected $fillable = [
        'OrderDate', 'AgentID'
    ];

    public function agent()
    {
        return $this->belongsTo(Agent::class, 'AgentID', 'AgentID');
    }
}
