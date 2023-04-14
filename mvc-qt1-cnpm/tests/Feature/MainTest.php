<?php

namespace Tests\Feature;

use Illuminate\Foundation\Testing\RefreshDatabase;
use Illuminate\Foundation\Testing\WithFaker;
use Tests\TestCase;

class MainTest extends TestCase
{
    /**
     * A basic feature test example.
     *
     * @return void
     */
    public function testRedirectRootRoute()
    {
        $response = $this->get('/');

        $response->assertStatus(302);
    }

    public function testTrueUsernamePassword()
    {
        $check = $this->post(route('process_login'), ['username' => 'admin', 'password' => '123456'])->isRedirect();
        $this->assertTrue($check);
    }

    public function testStoreAgent()
    {
        $code = $this->post(route('agent.store'), [
            'AgentName' => 'name123',
            'Address' => 'address123',
        ])->getStatusCode();

        $this->assertSame($code, 302);
    }

    public function testStoreItem()
    {
        $code = $this->post(route('item.store'), [
            'ItemName' => 'item 1',
            'Size' => 'size XL',
            'Price' => 1.4,
        ])->getStatusCode();

        $this->assertSame($code, 302);
    }


}
