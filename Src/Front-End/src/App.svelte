<script lang="ts">
import type Data from "./dto/Data";
import { sendData } from "./webapi/api";


  let visible= false;
 let userData : Data;
 let link : string  = "";


  async function submitClick(){
    link  = await sendData(userData);
    visible =!visible;
  }
</script>

		<div class="section-center">
			<div class="container">
				<div class="row">
					<div class="booking-form">
						<form on:submit|preventDefault={submitClick}>
							<div class="row">
								<div class="col-md-6">
									<div class="form-group">
										<span class="form-label">Phone Number</span>
										<input class="form-control" bind:value="{userData.phoneNumber}" type="text" placeholder="Enter Your Phone Number With Out +">
									</div>
								</div>
								<div class="col-md-6">
									<div class="form-group">
										<span class="form-label">Text</span>
										<textarea class="form-control" bind:value="{userData.text}" placeholder="Text For Send"></textarea>
									</div>
								</div>
							</div>
							<div class="row ">
                <div class="col-md-4"></div>
								<div class="col-md-4">
									<div class="form-btn">
										<button class="submit-btn" type="submit">Build Link</button>
									</div>
								</div>
                <div class="col-md-4"></div>
                {#if visible}
                  
                <div class="col-md-12 ">
                  <hr/>
                  <div class="form-group">
                    <textarea class="form-control m-3" bind:value="{link}" placeholder="Your Link"></textarea>
                  </div>
                </div>
                {/if}
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>

